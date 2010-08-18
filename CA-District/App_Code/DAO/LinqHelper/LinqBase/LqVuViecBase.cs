




/*
'===============================================================================
'  LinqHelper.DAO.VuViecBase
'===============================================================================
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using LinqHelper;
using LinqHelper.Entity;
using LinqHelper.DAO;

namespace LinqHelper.DAO
{
	public class LqVuViecBase
	{
		public LqProvider provider = new LqProvider();
		
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public LqVuViecBase()
		{
			// Nothing for now.
		}
		
		public void Insert(LqVuViecEntity obj)
		{
			provider.GetTable<LqVuViecEntity>().InsertOnSubmit(obj);
            provider.SubmitChanges();
		}

		public void Update(LqVuViecEntity _obj)
		{
			var q = from obj in provider.GetTable<LqVuViecEntity>()
                    where obj.Id == _obj.Id
                    select obj;
			LqVuViecEntity tmp = q.First<LqVuViecEntity>();
			
			tmp.SttvuViec = _obj.SttvuViec;
			tmp.IdDanhMucTin = _obj.IdDanhMucTin;
			tmp.MaRutGon = _obj.MaRutGon;
			tmp.IdDonViTiepNhan = _obj.IdDonViTiepNhan;
			tmp.IdDonViBaoCao = _obj.IdDonViBaoCao;
			tmp.IdDonViBat = _obj.IdDonViBat;
			tmp.ThoiGianXayRa = _obj.ThoiGianXayRa;
			tmp.ThoiGianBaoCao = _obj.ThoiGianBaoCao;
			tmp.ThoiGianPhatHien = _obj.ThoiGianPhatHien;
			tmp.NguoiPhatHien = _obj.NguoiPhatHien;
			tmp.IdNguonPhatHien = _obj.IdNguonPhatHien;
			tmp.IdPhanLoaiTheoChuyenDe = _obj.IdPhanLoaiTheoChuyenDe;
			tmp.IdPhanLoaiTheoDiaBan = _obj.IdPhanLoaiTheoDiaBan;
			tmp.SoNanNhan = _obj.SoNanNhan;
			tmp.IdTinhChatVuViec = _obj.IdTinhChatVuViec;
			tmp.IdKhamPha = _obj.IdKhamPha;
			tmp.IdNguyenNhanXayRa = _obj.IdNguyenNhanXayRa;
			tmp.IdPhuongThucThuDoan = _obj.IdPhuongThucThuDoan;
			tmp.IdPhuongTienGayAn = _obj.IdPhuongTienGayAn;
			tmp.IdCoToChuc = _obj.IdCoToChuc;
			tmp.SoDoiTuong = _obj.SoDoiTuong;
			tmp.NgayThucHien = _obj.NgayThucHien;
			tmp.NgayKetThuc = _obj.NgayKetThuc;
			tmp.IdDonViXuLy = _obj.IdDonViXuLy;
			tmp.IdKhoiToVuAn = _obj.IdKhoiToVuAn;
			tmp.IdNuoc = _obj.IdNuoc;
			tmp.IdTinh = _obj.IdTinh;
			tmp.IdHuyen = _obj.IdHuyen;
			tmp.IdXa = _obj.IdXa;
			tmp.IdThon = _obj.IdThon;
			tmp.Duong = _obj.Duong;
			tmp.SoNha = _obj.SoNha;
			tmp.IdOkhuVuc = _obj.IdOkhuVuc;
			tmp.IdToDanPho = _obj.IdToDanPho;
			tmp.IdKetQuaXuLy = _obj.IdKetQuaXuLy;
			tmp.IdXuLyHanhChinh = _obj.IdXuLyHanhChinh;
			tmp.TomTatNoiDung = _obj.TomTatNoiDung;
			tmp.TrinhSatBaoCao = _obj.TrinhSatBaoCao;
			tmp.IdDanhGiaTin = _obj.IdDanhGiaTin;
			tmp.TinhTrangKhamPha = _obj.TinhTrangKhamPha;
			tmp.IdCapChiDaoXuLyBanDau = _obj.IdCapChiDaoXuLyBanDau;
			tmp.IdHinhThucXuLyBanDau = _obj.IdHinhThucXuLyBanDau;
			tmp.SoHinhThucXuLyBanDau = _obj.SoHinhThucXuLyBanDau;
			tmp.NgayXuLy = _obj.NgayXuLy;
			tmp.NgayKetLuan = _obj.NgayKetLuan;
			tmp.SoDinhChiTamDinhChi = _obj.SoDinhChiTamDinhChi;
			tmp.NgayDinhChi = _obj.NgayDinhChi;
			tmp.SoBanAn = _obj.SoBanAn;
			tmp.NgayBanAn = _obj.NgayBanAn;
			tmp.SoHoSo = _obj.SoHoSo;
			tmp.MaDonVi = _obj.MaDonVi;
			tmp.NgayDangKy = _obj.NgayDangKy;
			tmp.SoDangKy = _obj.SoDangKy;
			tmp.NgayNopLuu = _obj.NgayNopLuu;
			tmp.SoNopLuu = _obj.SoNopLuu;
			tmp.TrangThaiCoToChuc = _obj.TrangThaiCoToChuc;
			tmp.IdLoaiDiaBan = _obj.IdLoaiDiaBan;
			tmp.IdTinhChatLienQuan = _obj.IdTinhChatLienQuan;
			tmp.NoiDungLienQuan = _obj.NoiDungLienQuan;
			tmp.TieuDeVuViec = _obj.TieuDeVuViec;
			tmp.IdVanDeKhac = _obj.IdVanDeKhac;
			tmp.IdXuLyKhac = _obj.IdXuLyKhac;
			tmp.TongSoBat = _obj.TongSoBat;
			tmp.TongSoTamGiam = _obj.TongSoTamGiam;
			tmp.TongSoTaiNgoai = _obj.TongSoTaiNgoai;
			tmp.TongSoTruyNa = _obj.TongSoTruyNa;
			tmp.NoiDungXuLyKhac = _obj.NoiDungXuLyKhac;
			tmp.IdNguoiTao = _obj.IdNguoiTao;
			tmp.NgayTao = _obj.NgayTao;
			tmp.IdNguoiCapNhat = _obj.IdNguoiCapNhat;
			tmp.NgayCapNhat = _obj.NgayCapNhat;
			tmp.TrangThai = _obj.TrangThai;
		}
		
		public void Delete(LqVuViecEntity obj)
		{
			provider.GetTable<LqVuViecEntity>().DeleteOnSubmit(obj);
            provider.SubmitChanges();
		}
		
		
		public void DeleteById(Guid Id)
		{
			var q = from obj in provider.GetTable<LqVuViecEntity>()
                    where obj.Id == Id
                    select obj;
					
            LqVuViecEntity ob = (LqVuViecEntity)q.First<LqVuViecEntity>();
            provider.GetTable<LqVuViecEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteBySttvuViec(string SttvuViec)
		{
			var q = from obj in provider.GetTable<LqVuViecEntity>()
                    where obj.SttvuViec == SttvuViec
                    select obj;
					
            LqVuViecEntity ob = (LqVuViecEntity)q.First<LqVuViecEntity>();
            provider.GetTable<LqVuViecEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdDanhMucTin(Guid IdDanhMucTin)
		{
			var q = from obj in provider.GetTable<LqVuViecEntity>()
                    where obj.IdDanhMucTin == IdDanhMucTin
                    select obj;
					
            LqVuViecEntity ob = (LqVuViecEntity)q.First<LqVuViecEntity>();
            provider.GetTable<LqVuViecEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaRutGon(string MaRutGon)
		{
			var q = from obj in provider.GetTable<LqVuViecEntity>()
                    where obj.MaRutGon == MaRutGon
                    select obj;
					
            LqVuViecEntity ob = (LqVuViecEntity)q.First<LqVuViecEntity>();
            provider.GetTable<LqVuViecEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdDonViTiepNhan(Guid IdDonViTiepNhan)
		{
			var q = from obj in provider.GetTable<LqVuViecEntity>()
                    where obj.IdDonViTiepNhan.Value == IdDonViTiepNhan
                    select obj;
					
            LqVuViecEntity ob = (LqVuViecEntity)q.First<LqVuViecEntity>();
            provider.GetTable<LqVuViecEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdDonViBaoCao(Guid IdDonViBaoCao)
		{
			var q = from obj in provider.GetTable<LqVuViecEntity>()
                    where obj.IdDonViBaoCao.Value == IdDonViBaoCao
                    select obj;
					
            LqVuViecEntity ob = (LqVuViecEntity)q.First<LqVuViecEntity>();
            provider.GetTable<LqVuViecEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdDonViBat(Guid IdDonViBat)
		{
			var q = from obj in provider.GetTable<LqVuViecEntity>()
                    where obj.IdDonViBat.Value == IdDonViBat
                    select obj;
					
            LqVuViecEntity ob = (LqVuViecEntity)q.First<LqVuViecEntity>();
            provider.GetTable<LqVuViecEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByThoiGianXayRa(DateTime ThoiGianXayRa)
		{
			var q = from obj in provider.GetTable<LqVuViecEntity>()
                    where obj.ThoiGianXayRa.Value == ThoiGianXayRa
                    select obj;
					
            LqVuViecEntity ob = (LqVuViecEntity)q.First<LqVuViecEntity>();
            provider.GetTable<LqVuViecEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByThoiGianBaoCao(DateTime ThoiGianBaoCao)
		{
			var q = from obj in provider.GetTable<LqVuViecEntity>()
                    where obj.ThoiGianBaoCao.Value == ThoiGianBaoCao
                    select obj;
					
            LqVuViecEntity ob = (LqVuViecEntity)q.First<LqVuViecEntity>();
            provider.GetTable<LqVuViecEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByThoiGianPhatHien(DateTime ThoiGianPhatHien)
		{
			var q = from obj in provider.GetTable<LqVuViecEntity>()
                    where obj.ThoiGianPhatHien.Value == ThoiGianPhatHien
                    select obj;
					
            LqVuViecEntity ob = (LqVuViecEntity)q.First<LqVuViecEntity>();
            provider.GetTable<LqVuViecEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNguoiPhatHien(string NguoiPhatHien)
		{
			var q = from obj in provider.GetTable<LqVuViecEntity>()
                    where obj.NguoiPhatHien == NguoiPhatHien
                    select obj;
					
            LqVuViecEntity ob = (LqVuViecEntity)q.First<LqVuViecEntity>();
            provider.GetTable<LqVuViecEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguonPhatHien(Guid IdNguonPhatHien)
		{
			var q = from obj in provider.GetTable<LqVuViecEntity>()
                    where obj.IdNguonPhatHien.Value == IdNguonPhatHien
                    select obj;
					
            LqVuViecEntity ob = (LqVuViecEntity)q.First<LqVuViecEntity>();
            provider.GetTable<LqVuViecEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdPhanLoaiTheoChuyenDe(Guid IdPhanLoaiTheoChuyenDe)
		{
			var q = from obj in provider.GetTable<LqVuViecEntity>()
                    where obj.IdPhanLoaiTheoChuyenDe.Value == IdPhanLoaiTheoChuyenDe
                    select obj;
					
            LqVuViecEntity ob = (LqVuViecEntity)q.First<LqVuViecEntity>();
            provider.GetTable<LqVuViecEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdPhanLoaiTheoDiaBan(Guid IdPhanLoaiTheoDiaBan)
		{
			var q = from obj in provider.GetTable<LqVuViecEntity>()
                    where obj.IdPhanLoaiTheoDiaBan.Value == IdPhanLoaiTheoDiaBan
                    select obj;
					
            LqVuViecEntity ob = (LqVuViecEntity)q.First<LqVuViecEntity>();
            provider.GetTable<LqVuViecEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteBySoNanNhan(int SoNanNhan)
		{
			var q = from obj in provider.GetTable<LqVuViecEntity>()
                    where obj.SoNanNhan.Value == SoNanNhan
                    select obj;
					
            LqVuViecEntity ob = (LqVuViecEntity)q.First<LqVuViecEntity>();
            provider.GetTable<LqVuViecEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdTinhChatVuViec(Guid IdTinhChatVuViec)
		{
			var q = from obj in provider.GetTable<LqVuViecEntity>()
                    where obj.IdTinhChatVuViec.Value == IdTinhChatVuViec
                    select obj;
					
            LqVuViecEntity ob = (LqVuViecEntity)q.First<LqVuViecEntity>();
            provider.GetTable<LqVuViecEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdKhamPha(Guid IdKhamPha)
		{
			var q = from obj in provider.GetTable<LqVuViecEntity>()
                    where obj.IdKhamPha.Value == IdKhamPha
                    select obj;
					
            LqVuViecEntity ob = (LqVuViecEntity)q.First<LqVuViecEntity>();
            provider.GetTable<LqVuViecEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguyenNhanXayRa(Guid IdNguyenNhanXayRa)
		{
			var q = from obj in provider.GetTable<LqVuViecEntity>()
                    where obj.IdNguyenNhanXayRa.Value == IdNguyenNhanXayRa
                    select obj;
					
            LqVuViecEntity ob = (LqVuViecEntity)q.First<LqVuViecEntity>();
            provider.GetTable<LqVuViecEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdPhuongThucThuDoan(Guid IdPhuongThucThuDoan)
		{
			var q = from obj in provider.GetTable<LqVuViecEntity>()
                    where obj.IdPhuongThucThuDoan.Value == IdPhuongThucThuDoan
                    select obj;
					
            LqVuViecEntity ob = (LqVuViecEntity)q.First<LqVuViecEntity>();
            provider.GetTable<LqVuViecEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdPhuongTienGayAn(Guid IdPhuongTienGayAn)
		{
			var q = from obj in provider.GetTable<LqVuViecEntity>()
                    where obj.IdPhuongTienGayAn.Value == IdPhuongTienGayAn
                    select obj;
					
            LqVuViecEntity ob = (LqVuViecEntity)q.First<LqVuViecEntity>();
            provider.GetTable<LqVuViecEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdCoToChuc(Guid IdCoToChuc)
		{
			var q = from obj in provider.GetTable<LqVuViecEntity>()
                    where obj.IdCoToChuc.Value == IdCoToChuc
                    select obj;
					
            LqVuViecEntity ob = (LqVuViecEntity)q.First<LqVuViecEntity>();
            provider.GetTable<LqVuViecEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteBySoDoiTuong(int SoDoiTuong)
		{
			var q = from obj in provider.GetTable<LqVuViecEntity>()
                    where obj.SoDoiTuong.Value == SoDoiTuong
                    select obj;
					
            LqVuViecEntity ob = (LqVuViecEntity)q.First<LqVuViecEntity>();
            provider.GetTable<LqVuViecEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayThucHien(DateTime NgayThucHien)
		{
			var q = from obj in provider.GetTable<LqVuViecEntity>()
                    where obj.NgayThucHien.Value == NgayThucHien
                    select obj;
					
            LqVuViecEntity ob = (LqVuViecEntity)q.First<LqVuViecEntity>();
            provider.GetTable<LqVuViecEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayKetThuc(DateTime NgayKetThuc)
		{
			var q = from obj in provider.GetTable<LqVuViecEntity>()
                    where obj.NgayKetThuc.Value == NgayKetThuc
                    select obj;
					
            LqVuViecEntity ob = (LqVuViecEntity)q.First<LqVuViecEntity>();
            provider.GetTable<LqVuViecEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdDonViXuLy(Guid IdDonViXuLy)
		{
			var q = from obj in provider.GetTable<LqVuViecEntity>()
                    where obj.IdDonViXuLy.Value == IdDonViXuLy
                    select obj;
					
            LqVuViecEntity ob = (LqVuViecEntity)q.First<LqVuViecEntity>();
            provider.GetTable<LqVuViecEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdKhoiToVuAn(Guid IdKhoiToVuAn)
		{
			var q = from obj in provider.GetTable<LqVuViecEntity>()
                    where obj.IdKhoiToVuAn.Value == IdKhoiToVuAn
                    select obj;
					
            LqVuViecEntity ob = (LqVuViecEntity)q.First<LqVuViecEntity>();
            provider.GetTable<LqVuViecEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNuoc(Guid IdNuoc)
		{
			var q = from obj in provider.GetTable<LqVuViecEntity>()
                    where obj.IdNuoc.Value == IdNuoc
                    select obj;
					
            LqVuViecEntity ob = (LqVuViecEntity)q.First<LqVuViecEntity>();
            provider.GetTable<LqVuViecEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdTinh(Guid IdTinh)
		{
			var q = from obj in provider.GetTable<LqVuViecEntity>()
                    where obj.IdTinh.Value == IdTinh
                    select obj;
					
            LqVuViecEntity ob = (LqVuViecEntity)q.First<LqVuViecEntity>();
            provider.GetTable<LqVuViecEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdHuyen(Guid IdHuyen)
		{
			var q = from obj in provider.GetTable<LqVuViecEntity>()
                    where obj.IdHuyen.Value == IdHuyen
                    select obj;
					
            LqVuViecEntity ob = (LqVuViecEntity)q.First<LqVuViecEntity>();
            provider.GetTable<LqVuViecEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdXa(Guid IdXa)
		{
			var q = from obj in provider.GetTable<LqVuViecEntity>()
                    where obj.IdXa.Value == IdXa
                    select obj;
					
            LqVuViecEntity ob = (LqVuViecEntity)q.First<LqVuViecEntity>();
            provider.GetTable<LqVuViecEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdThon(Guid IdThon)
		{
			var q = from obj in provider.GetTable<LqVuViecEntity>()
                    where obj.IdThon.Value == IdThon
                    select obj;
					
            LqVuViecEntity ob = (LqVuViecEntity)q.First<LqVuViecEntity>();
            provider.GetTable<LqVuViecEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByDuong(string Duong)
		{
			var q = from obj in provider.GetTable<LqVuViecEntity>()
                    where obj.Duong == Duong
                    select obj;
					
            LqVuViecEntity ob = (LqVuViecEntity)q.First<LqVuViecEntity>();
            provider.GetTable<LqVuViecEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteBySoNha(string SoNha)
		{
			var q = from obj in provider.GetTable<LqVuViecEntity>()
                    where obj.SoNha == SoNha
                    select obj;
					
            LqVuViecEntity ob = (LqVuViecEntity)q.First<LqVuViecEntity>();
            provider.GetTable<LqVuViecEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdOkhuVuc(Guid IdOkhuVuc)
		{
			var q = from obj in provider.GetTable<LqVuViecEntity>()
                    where obj.IdOkhuVuc.Value == IdOkhuVuc
                    select obj;
					
            LqVuViecEntity ob = (LqVuViecEntity)q.First<LqVuViecEntity>();
            provider.GetTable<LqVuViecEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdToDanPho(Guid IdToDanPho)
		{
			var q = from obj in provider.GetTable<LqVuViecEntity>()
                    where obj.IdToDanPho.Value == IdToDanPho
                    select obj;
					
            LqVuViecEntity ob = (LqVuViecEntity)q.First<LqVuViecEntity>();
            provider.GetTable<LqVuViecEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdKetQuaXuLy(Guid IdKetQuaXuLy)
		{
			var q = from obj in provider.GetTable<LqVuViecEntity>()
                    where obj.IdKetQuaXuLy.Value == IdKetQuaXuLy
                    select obj;
					
            LqVuViecEntity ob = (LqVuViecEntity)q.First<LqVuViecEntity>();
            provider.GetTable<LqVuViecEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdXuLyHanhChinh(Guid IdXuLyHanhChinh)
		{
			var q = from obj in provider.GetTable<LqVuViecEntity>()
                    where obj.IdXuLyHanhChinh.Value == IdXuLyHanhChinh
                    select obj;
					
            LqVuViecEntity ob = (LqVuViecEntity)q.First<LqVuViecEntity>();
            provider.GetTable<LqVuViecEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTomTatNoiDung(string TomTatNoiDung)
		{
			var q = from obj in provider.GetTable<LqVuViecEntity>()
                    where obj.TomTatNoiDung == TomTatNoiDung
                    select obj;
					
            LqVuViecEntity ob = (LqVuViecEntity)q.First<LqVuViecEntity>();
            provider.GetTable<LqVuViecEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTrinhSatBaoCao(string TrinhSatBaoCao)
		{
			var q = from obj in provider.GetTable<LqVuViecEntity>()
                    where obj.TrinhSatBaoCao == TrinhSatBaoCao
                    select obj;
					
            LqVuViecEntity ob = (LqVuViecEntity)q.First<LqVuViecEntity>();
            provider.GetTable<LqVuViecEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdDanhGiaTin(Guid IdDanhGiaTin)
		{
			var q = from obj in provider.GetTable<LqVuViecEntity>()
                    where obj.IdDanhGiaTin.Value == IdDanhGiaTin
                    select obj;
					
            LqVuViecEntity ob = (LqVuViecEntity)q.First<LqVuViecEntity>();
            provider.GetTable<LqVuViecEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTinhTrangKhamPha(string TinhTrangKhamPha)
		{
			var q = from obj in provider.GetTable<LqVuViecEntity>()
                    where obj.TinhTrangKhamPha == TinhTrangKhamPha
                    select obj;
					
            LqVuViecEntity ob = (LqVuViecEntity)q.First<LqVuViecEntity>();
            provider.GetTable<LqVuViecEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdCapChiDaoXuLyBanDau(Guid IdCapChiDaoXuLyBanDau)
		{
			var q = from obj in provider.GetTable<LqVuViecEntity>()
                    where obj.IdCapChiDaoXuLyBanDau.Value == IdCapChiDaoXuLyBanDau
                    select obj;
					
            LqVuViecEntity ob = (LqVuViecEntity)q.First<LqVuViecEntity>();
            provider.GetTable<LqVuViecEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdHinhThucXuLyBanDau(Guid IdHinhThucXuLyBanDau)
		{
			var q = from obj in provider.GetTable<LqVuViecEntity>()
                    where obj.IdHinhThucXuLyBanDau.Value == IdHinhThucXuLyBanDau
                    select obj;
					
            LqVuViecEntity ob = (LqVuViecEntity)q.First<LqVuViecEntity>();
            provider.GetTable<LqVuViecEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteBySoHinhThucXuLyBanDau(string SoHinhThucXuLyBanDau)
		{
			var q = from obj in provider.GetTable<LqVuViecEntity>()
                    where obj.SoHinhThucXuLyBanDau == SoHinhThucXuLyBanDau
                    select obj;
					
            LqVuViecEntity ob = (LqVuViecEntity)q.First<LqVuViecEntity>();
            provider.GetTable<LqVuViecEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayXuLy(DateTime NgayXuLy)
		{
			var q = from obj in provider.GetTable<LqVuViecEntity>()
                    where obj.NgayXuLy.Value == NgayXuLy
                    select obj;
					
            LqVuViecEntity ob = (LqVuViecEntity)q.First<LqVuViecEntity>();
            provider.GetTable<LqVuViecEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayKetLuan(DateTime NgayKetLuan)
		{
			var q = from obj in provider.GetTable<LqVuViecEntity>()
                    where obj.NgayKetLuan.Value == NgayKetLuan
                    select obj;
					
            LqVuViecEntity ob = (LqVuViecEntity)q.First<LqVuViecEntity>();
            provider.GetTable<LqVuViecEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteBySoDinhChiTamDinhChi(string SoDinhChiTamDinhChi)
		{
			var q = from obj in provider.GetTable<LqVuViecEntity>()
                    where obj.SoDinhChiTamDinhChi == SoDinhChiTamDinhChi
                    select obj;
					
            LqVuViecEntity ob = (LqVuViecEntity)q.First<LqVuViecEntity>();
            provider.GetTable<LqVuViecEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayDinhChi(DateTime NgayDinhChi)
		{
			var q = from obj in provider.GetTable<LqVuViecEntity>()
                    where obj.NgayDinhChi.Value == NgayDinhChi
                    select obj;
					
            LqVuViecEntity ob = (LqVuViecEntity)q.First<LqVuViecEntity>();
            provider.GetTable<LqVuViecEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteBySoBanAn(string SoBanAn)
		{
			var q = from obj in provider.GetTable<LqVuViecEntity>()
                    where obj.SoBanAn == SoBanAn
                    select obj;
					
            LqVuViecEntity ob = (LqVuViecEntity)q.First<LqVuViecEntity>();
            provider.GetTable<LqVuViecEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayBanAn(DateTime NgayBanAn)
		{
			var q = from obj in provider.GetTable<LqVuViecEntity>()
                    where obj.NgayBanAn.Value == NgayBanAn
                    select obj;
					
            LqVuViecEntity ob = (LqVuViecEntity)q.First<LqVuViecEntity>();
            provider.GetTable<LqVuViecEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteBySoHoSo(string SoHoSo)
		{
			var q = from obj in provider.GetTable<LqVuViecEntity>()
                    where obj.SoHoSo == SoHoSo
                    select obj;
					
            LqVuViecEntity ob = (LqVuViecEntity)q.First<LqVuViecEntity>();
            provider.GetTable<LqVuViecEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByMaDonVi(string MaDonVi)
		{
			var q = from obj in provider.GetTable<LqVuViecEntity>()
                    where obj.MaDonVi == MaDonVi
                    select obj;
					
            LqVuViecEntity ob = (LqVuViecEntity)q.First<LqVuViecEntity>();
            provider.GetTable<LqVuViecEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayDangKy(DateTime NgayDangKy)
		{
			var q = from obj in provider.GetTable<LqVuViecEntity>()
                    where obj.NgayDangKy.Value == NgayDangKy
                    select obj;
					
            LqVuViecEntity ob = (LqVuViecEntity)q.First<LqVuViecEntity>();
            provider.GetTable<LqVuViecEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteBySoDangKy(string SoDangKy)
		{
			var q = from obj in provider.GetTable<LqVuViecEntity>()
                    where obj.SoDangKy == SoDangKy
                    select obj;
					
            LqVuViecEntity ob = (LqVuViecEntity)q.First<LqVuViecEntity>();
            provider.GetTable<LqVuViecEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayNopLuu(DateTime NgayNopLuu)
		{
			var q = from obj in provider.GetTable<LqVuViecEntity>()
                    where obj.NgayNopLuu.Value == NgayNopLuu
                    select obj;
					
            LqVuViecEntity ob = (LqVuViecEntity)q.First<LqVuViecEntity>();
            provider.GetTable<LqVuViecEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteBySoNopLuu(DateTime SoNopLuu)
		{
			var q = from obj in provider.GetTable<LqVuViecEntity>()
                    where obj.SoNopLuu.Value == SoNopLuu
                    select obj;
					
            LqVuViecEntity ob = (LqVuViecEntity)q.First<LqVuViecEntity>();
            provider.GetTable<LqVuViecEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTrangThaiCoToChuc(string TrangThaiCoToChuc)
		{
			var q = from obj in provider.GetTable<LqVuViecEntity>()
                    where obj.TrangThaiCoToChuc == TrangThaiCoToChuc
                    select obj;
					
            LqVuViecEntity ob = (LqVuViecEntity)q.First<LqVuViecEntity>();
            provider.GetTable<LqVuViecEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdLoaiDiaBan(Guid IdLoaiDiaBan)
		{
			var q = from obj in provider.GetTable<LqVuViecEntity>()
                    where obj.IdLoaiDiaBan.Value == IdLoaiDiaBan
                    select obj;
					
            LqVuViecEntity ob = (LqVuViecEntity)q.First<LqVuViecEntity>();
            provider.GetTable<LqVuViecEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdTinhChatLienQuan(Guid IdTinhChatLienQuan)
		{
			var q = from obj in provider.GetTable<LqVuViecEntity>()
                    where obj.IdTinhChatLienQuan.Value == IdTinhChatLienQuan
                    select obj;
					
            LqVuViecEntity ob = (LqVuViecEntity)q.First<LqVuViecEntity>();
            provider.GetTable<LqVuViecEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNoiDungLienQuan(string NoiDungLienQuan)
		{
			var q = from obj in provider.GetTable<LqVuViecEntity>()
                    where obj.NoiDungLienQuan == NoiDungLienQuan
                    select obj;
					
            LqVuViecEntity ob = (LqVuViecEntity)q.First<LqVuViecEntity>();
            provider.GetTable<LqVuViecEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTieuDeVuViec(string TieuDeVuViec)
		{
			var q = from obj in provider.GetTable<LqVuViecEntity>()
                    where obj.TieuDeVuViec == TieuDeVuViec
                    select obj;
					
            LqVuViecEntity ob = (LqVuViecEntity)q.First<LqVuViecEntity>();
            provider.GetTable<LqVuViecEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdVanDeKhac(Guid IdVanDeKhac)
		{
			var q = from obj in provider.GetTable<LqVuViecEntity>()
                    where obj.IdVanDeKhac.Value == IdVanDeKhac
                    select obj;
					
            LqVuViecEntity ob = (LqVuViecEntity)q.First<LqVuViecEntity>();
            provider.GetTable<LqVuViecEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdXuLyKhac(Guid IdXuLyKhac)
		{
			var q = from obj in provider.GetTable<LqVuViecEntity>()
                    where obj.IdXuLyKhac.Value == IdXuLyKhac
                    select obj;
					
            LqVuViecEntity ob = (LqVuViecEntity)q.First<LqVuViecEntity>();
            provider.GetTable<LqVuViecEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTongSoBat(int TongSoBat)
		{
			var q = from obj in provider.GetTable<LqVuViecEntity>()
                    where obj.TongSoBat.Value == TongSoBat
                    select obj;
					
            LqVuViecEntity ob = (LqVuViecEntity)q.First<LqVuViecEntity>();
            provider.GetTable<LqVuViecEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTongSoTamGiam(int TongSoTamGiam)
		{
			var q = from obj in provider.GetTable<LqVuViecEntity>()
                    where obj.TongSoTamGiam.Value == TongSoTamGiam
                    select obj;
					
            LqVuViecEntity ob = (LqVuViecEntity)q.First<LqVuViecEntity>();
            provider.GetTable<LqVuViecEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTongSoTaiNgoai(int TongSoTaiNgoai)
		{
			var q = from obj in provider.GetTable<LqVuViecEntity>()
                    where obj.TongSoTaiNgoai.Value == TongSoTaiNgoai
                    select obj;
					
            LqVuViecEntity ob = (LqVuViecEntity)q.First<LqVuViecEntity>();
            provider.GetTable<LqVuViecEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTongSoTruyNa(int TongSoTruyNa)
		{
			var q = from obj in provider.GetTable<LqVuViecEntity>()
                    where obj.TongSoTruyNa.Value == TongSoTruyNa
                    select obj;
					
            LqVuViecEntity ob = (LqVuViecEntity)q.First<LqVuViecEntity>();
            provider.GetTable<LqVuViecEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNoiDungXuLyKhac(string NoiDungXuLyKhac)
		{
			var q = from obj in provider.GetTable<LqVuViecEntity>()
                    where obj.NoiDungXuLyKhac == NoiDungXuLyKhac
                    select obj;
					
            LqVuViecEntity ob = (LqVuViecEntity)q.First<LqVuViecEntity>();
            provider.GetTable<LqVuViecEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			var q = from obj in provider.GetTable<LqVuViecEntity>()
                    where obj.IdNguoiTao.Value == IdNguoiTao
                    select obj;
					
            LqVuViecEntity ob = (LqVuViecEntity)q.First<LqVuViecEntity>();
            provider.GetTable<LqVuViecEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayTao(DateTime NgayTao)
		{
			var q = from obj in provider.GetTable<LqVuViecEntity>()
                    where obj.NgayTao == NgayTao
                    select obj;
					
            LqVuViecEntity ob = (LqVuViecEntity)q.First<LqVuViecEntity>();
            provider.GetTable<LqVuViecEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var q = from obj in provider.GetTable<LqVuViecEntity>()
                    where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                    select obj;
					
            LqVuViecEntity ob = (LqVuViecEntity)q.First<LqVuViecEntity>();
            provider.GetTable<LqVuViecEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			var q = from obj in provider.GetTable<LqVuViecEntity>()
                    where obj.NgayCapNhat == NgayCapNhat
                    select obj;
					
            LqVuViecEntity ob = (LqVuViecEntity)q.First<LqVuViecEntity>();
            provider.GetTable<LqVuViecEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public void DeleteByTrangThai(bool TrangThai)
		{
			var q = from obj in provider.GetTable<LqVuViecEntity>()
                    where obj.TrangThai == TrangThai
                    select obj;
					
            LqVuViecEntity ob = (LqVuViecEntity)q.First<LqVuViecEntity>();
            provider.GetTable<LqVuViecEntity>().DeleteOnSubmit(ob);
            provider.SubmitChanges();
		}
		
		
		public LqVuViecEntity SelectOne(Guid Id)
		{
			var query = from obj in provider.GetTable<LqVuViecEntity>()
                        where obj.Id == Id
                        select obj;
            return query.First<LqVuViecEntity>();
		}

		public List<LqVuViecEntity> SelectAll()
		{
			var query = from obj in provider.GetTable<LqVuViecEntity>()
                        select obj;
            return query.ToList<LqVuViecEntity>();
		}
		
		
		public List<LqVuViecEntity> SelectById(Guid Id)
		{
			var query = from obj in provider.GetTable<LqVuViecEntity>()
                        where obj.Id == Id
                        select obj;
            return query.ToList<LqVuViecEntity>();
		}
		
		
		public List<LqVuViecEntity> SelectBySttvuViec(string SttvuViec)
		{
			var query = from obj in provider.GetTable<LqVuViecEntity>()
                        where obj.SttvuViec == SttvuViec
                        select obj;
            return query.ToList<LqVuViecEntity>();
		}
		
		
		public List<LqVuViecEntity> SelectByIdDanhMucTin(Guid IdDanhMucTin)
		{
			var query = from obj in provider.GetTable<LqVuViecEntity>()
                        where obj.IdDanhMucTin == IdDanhMucTin
                        select obj;
            return query.ToList<LqVuViecEntity>();
		}
		
		
		public List<LqVuViecEntity> SelectByMaRutGon(string MaRutGon)
		{
			var query = from obj in provider.GetTable<LqVuViecEntity>()
                        where obj.MaRutGon == MaRutGon
                        select obj;
            return query.ToList<LqVuViecEntity>();
		}
		
		
		public List<LqVuViecEntity> SelectByIdDonViTiepNhan(Guid IdDonViTiepNhan)
		{
			var query = from obj in provider.GetTable<LqVuViecEntity>()
                        where obj.IdDonViTiepNhan.Value == IdDonViTiepNhan
                        select obj;
            return query.ToList<LqVuViecEntity>();
		}
		
		
		public List<LqVuViecEntity> SelectByIdDonViBaoCao(Guid IdDonViBaoCao)
		{
			var query = from obj in provider.GetTable<LqVuViecEntity>()
                        where obj.IdDonViBaoCao.Value == IdDonViBaoCao
                        select obj;
            return query.ToList<LqVuViecEntity>();
		}
		
		
		public List<LqVuViecEntity> SelectByIdDonViBat(Guid IdDonViBat)
		{
			var query = from obj in provider.GetTable<LqVuViecEntity>()
                        where obj.IdDonViBat.Value == IdDonViBat
                        select obj;
            return query.ToList<LqVuViecEntity>();
		}
		
		
		public List<LqVuViecEntity> SelectByThoiGianXayRa(DateTime ThoiGianXayRa)
		{
			var query = from obj in provider.GetTable<LqVuViecEntity>()
                        where obj.ThoiGianXayRa.Value == ThoiGianXayRa
                        select obj;
            return query.ToList<LqVuViecEntity>();
		}
		
		
		public List<LqVuViecEntity> SelectByThoiGianBaoCao(DateTime ThoiGianBaoCao)
		{
			var query = from obj in provider.GetTable<LqVuViecEntity>()
                        where obj.ThoiGianBaoCao.Value == ThoiGianBaoCao
                        select obj;
            return query.ToList<LqVuViecEntity>();
		}
		
		
		public List<LqVuViecEntity> SelectByThoiGianPhatHien(DateTime ThoiGianPhatHien)
		{
			var query = from obj in provider.GetTable<LqVuViecEntity>()
                        where obj.ThoiGianPhatHien.Value == ThoiGianPhatHien
                        select obj;
            return query.ToList<LqVuViecEntity>();
		}
		
		
		public List<LqVuViecEntity> SelectByNguoiPhatHien(string NguoiPhatHien)
		{
			var query = from obj in provider.GetTable<LqVuViecEntity>()
                        where obj.NguoiPhatHien == NguoiPhatHien
                        select obj;
            return query.ToList<LqVuViecEntity>();
		}
		
		
		public List<LqVuViecEntity> SelectByIdNguonPhatHien(Guid IdNguonPhatHien)
		{
			var query = from obj in provider.GetTable<LqVuViecEntity>()
                        where obj.IdNguonPhatHien.Value == IdNguonPhatHien
                        select obj;
            return query.ToList<LqVuViecEntity>();
		}
		
		
		public List<LqVuViecEntity> SelectByIdPhanLoaiTheoChuyenDe(Guid IdPhanLoaiTheoChuyenDe)
		{
			var query = from obj in provider.GetTable<LqVuViecEntity>()
                        where obj.IdPhanLoaiTheoChuyenDe.Value == IdPhanLoaiTheoChuyenDe
                        select obj;
            return query.ToList<LqVuViecEntity>();
		}
		
		
		public List<LqVuViecEntity> SelectByIdPhanLoaiTheoDiaBan(Guid IdPhanLoaiTheoDiaBan)
		{
			var query = from obj in provider.GetTable<LqVuViecEntity>()
                        where obj.IdPhanLoaiTheoDiaBan.Value == IdPhanLoaiTheoDiaBan
                        select obj;
            return query.ToList<LqVuViecEntity>();
		}
		
		
		public List<LqVuViecEntity> SelectBySoNanNhan(int SoNanNhan)
		{
			var query = from obj in provider.GetTable<LqVuViecEntity>()
                        where obj.SoNanNhan.Value == SoNanNhan
                        select obj;
            return query.ToList<LqVuViecEntity>();
		}
		
		
		public List<LqVuViecEntity> SelectByIdTinhChatVuViec(Guid IdTinhChatVuViec)
		{
			var query = from obj in provider.GetTable<LqVuViecEntity>()
                        where obj.IdTinhChatVuViec.Value == IdTinhChatVuViec
                        select obj;
            return query.ToList<LqVuViecEntity>();
		}
		
		
		public List<LqVuViecEntity> SelectByIdKhamPha(Guid IdKhamPha)
		{
			var query = from obj in provider.GetTable<LqVuViecEntity>()
                        where obj.IdKhamPha.Value == IdKhamPha
                        select obj;
            return query.ToList<LqVuViecEntity>();
		}
		
		
		public List<LqVuViecEntity> SelectByIdNguyenNhanXayRa(Guid IdNguyenNhanXayRa)
		{
			var query = from obj in provider.GetTable<LqVuViecEntity>()
                        where obj.IdNguyenNhanXayRa.Value == IdNguyenNhanXayRa
                        select obj;
            return query.ToList<LqVuViecEntity>();
		}
		
		
		public List<LqVuViecEntity> SelectByIdPhuongThucThuDoan(Guid IdPhuongThucThuDoan)
		{
			var query = from obj in provider.GetTable<LqVuViecEntity>()
                        where obj.IdPhuongThucThuDoan.Value == IdPhuongThucThuDoan
                        select obj;
            return query.ToList<LqVuViecEntity>();
		}
		
		
		public List<LqVuViecEntity> SelectByIdPhuongTienGayAn(Guid IdPhuongTienGayAn)
		{
			var query = from obj in provider.GetTable<LqVuViecEntity>()
                        where obj.IdPhuongTienGayAn.Value == IdPhuongTienGayAn
                        select obj;
            return query.ToList<LqVuViecEntity>();
		}
		
		
		public List<LqVuViecEntity> SelectByIdCoToChuc(Guid IdCoToChuc)
		{
			var query = from obj in provider.GetTable<LqVuViecEntity>()
                        where obj.IdCoToChuc.Value == IdCoToChuc
                        select obj;
            return query.ToList<LqVuViecEntity>();
		}
		
		
		public List<LqVuViecEntity> SelectBySoDoiTuong(int SoDoiTuong)
		{
			var query = from obj in provider.GetTable<LqVuViecEntity>()
                        where obj.SoDoiTuong.Value == SoDoiTuong
                        select obj;
            return query.ToList<LqVuViecEntity>();
		}
		
		
		public List<LqVuViecEntity> SelectByNgayThucHien(DateTime NgayThucHien)
		{
			var query = from obj in provider.GetTable<LqVuViecEntity>()
                        where obj.NgayThucHien.Value == NgayThucHien
                        select obj;
            return query.ToList<LqVuViecEntity>();
		}
		
		
		public List<LqVuViecEntity> SelectByNgayKetThuc(DateTime NgayKetThuc)
		{
			var query = from obj in provider.GetTable<LqVuViecEntity>()
                        where obj.NgayKetThuc.Value == NgayKetThuc
                        select obj;
            return query.ToList<LqVuViecEntity>();
		}
		
		
		public List<LqVuViecEntity> SelectByIdDonViXuLy(Guid IdDonViXuLy)
		{
			var query = from obj in provider.GetTable<LqVuViecEntity>()
                        where obj.IdDonViXuLy.Value == IdDonViXuLy
                        select obj;
            return query.ToList<LqVuViecEntity>();
		}
		
		
		public List<LqVuViecEntity> SelectByIdKhoiToVuAn(Guid IdKhoiToVuAn)
		{
			var query = from obj in provider.GetTable<LqVuViecEntity>()
                        where obj.IdKhoiToVuAn.Value == IdKhoiToVuAn
                        select obj;
            return query.ToList<LqVuViecEntity>();
		}
		
		
		public List<LqVuViecEntity> SelectByIdNuoc(Guid IdNuoc)
		{
			var query = from obj in provider.GetTable<LqVuViecEntity>()
                        where obj.IdNuoc.Value == IdNuoc
                        select obj;
            return query.ToList<LqVuViecEntity>();
		}
		
		
		public List<LqVuViecEntity> SelectByIdTinh(Guid IdTinh)
		{
			var query = from obj in provider.GetTable<LqVuViecEntity>()
                        where obj.IdTinh.Value == IdTinh
                        select obj;
            return query.ToList<LqVuViecEntity>();
		}
		
		
		public List<LqVuViecEntity> SelectByIdHuyen(Guid IdHuyen)
		{
			var query = from obj in provider.GetTable<LqVuViecEntity>()
                        where obj.IdHuyen.Value == IdHuyen
                        select obj;
            return query.ToList<LqVuViecEntity>();
		}
		
		
		public List<LqVuViecEntity> SelectByIdXa(Guid IdXa)
		{
			var query = from obj in provider.GetTable<LqVuViecEntity>()
                        where obj.IdXa.Value == IdXa
                        select obj;
            return query.ToList<LqVuViecEntity>();
		}
		
		
		public List<LqVuViecEntity> SelectByIdThon(Guid IdThon)
		{
			var query = from obj in provider.GetTable<LqVuViecEntity>()
                        where obj.IdThon.Value == IdThon
                        select obj;
            return query.ToList<LqVuViecEntity>();
		}
		
		
		public List<LqVuViecEntity> SelectByDuong(string Duong)
		{
			var query = from obj in provider.GetTable<LqVuViecEntity>()
                        where obj.Duong == Duong
                        select obj;
            return query.ToList<LqVuViecEntity>();
		}
		
		
		public List<LqVuViecEntity> SelectBySoNha(string SoNha)
		{
			var query = from obj in provider.GetTable<LqVuViecEntity>()
                        where obj.SoNha == SoNha
                        select obj;
            return query.ToList<LqVuViecEntity>();
		}
		
		
		public List<LqVuViecEntity> SelectByIdOkhuVuc(Guid IdOkhuVuc)
		{
			var query = from obj in provider.GetTable<LqVuViecEntity>()
                        where obj.IdOkhuVuc.Value == IdOkhuVuc
                        select obj;
            return query.ToList<LqVuViecEntity>();
		}
		
		
		public List<LqVuViecEntity> SelectByIdToDanPho(Guid IdToDanPho)
		{
			var query = from obj in provider.GetTable<LqVuViecEntity>()
                        where obj.IdToDanPho.Value == IdToDanPho
                        select obj;
            return query.ToList<LqVuViecEntity>();
		}
		
		
		public List<LqVuViecEntity> SelectByIdKetQuaXuLy(Guid IdKetQuaXuLy)
		{
			var query = from obj in provider.GetTable<LqVuViecEntity>()
                        where obj.IdKetQuaXuLy.Value == IdKetQuaXuLy
                        select obj;
            return query.ToList<LqVuViecEntity>();
		}
		
		
		public List<LqVuViecEntity> SelectByIdXuLyHanhChinh(Guid IdXuLyHanhChinh)
		{
			var query = from obj in provider.GetTable<LqVuViecEntity>()
                        where obj.IdXuLyHanhChinh.Value == IdXuLyHanhChinh
                        select obj;
            return query.ToList<LqVuViecEntity>();
		}
		
		
		public List<LqVuViecEntity> SelectByTomTatNoiDung(string TomTatNoiDung)
		{
			var query = from obj in provider.GetTable<LqVuViecEntity>()
                        where obj.TomTatNoiDung == TomTatNoiDung
                        select obj;
            return query.ToList<LqVuViecEntity>();
		}
		
		
		public List<LqVuViecEntity> SelectByTrinhSatBaoCao(string TrinhSatBaoCao)
		{
			var query = from obj in provider.GetTable<LqVuViecEntity>()
                        where obj.TrinhSatBaoCao == TrinhSatBaoCao
                        select obj;
            return query.ToList<LqVuViecEntity>();
		}
		
		
		public List<LqVuViecEntity> SelectByIdDanhGiaTin(Guid IdDanhGiaTin)
		{
			var query = from obj in provider.GetTable<LqVuViecEntity>()
                        where obj.IdDanhGiaTin.Value == IdDanhGiaTin
                        select obj;
            return query.ToList<LqVuViecEntity>();
		}
		
		
		public List<LqVuViecEntity> SelectByTinhTrangKhamPha(string TinhTrangKhamPha)
		{
			var query = from obj in provider.GetTable<LqVuViecEntity>()
                        where obj.TinhTrangKhamPha == TinhTrangKhamPha
                        select obj;
            return query.ToList<LqVuViecEntity>();
		}
		
		
		public List<LqVuViecEntity> SelectByIdCapChiDaoXuLyBanDau(Guid IdCapChiDaoXuLyBanDau)
		{
			var query = from obj in provider.GetTable<LqVuViecEntity>()
                        where obj.IdCapChiDaoXuLyBanDau.Value == IdCapChiDaoXuLyBanDau
                        select obj;
            return query.ToList<LqVuViecEntity>();
		}
		
		
		public List<LqVuViecEntity> SelectByIdHinhThucXuLyBanDau(Guid IdHinhThucXuLyBanDau)
		{
			var query = from obj in provider.GetTable<LqVuViecEntity>()
                        where obj.IdHinhThucXuLyBanDau.Value == IdHinhThucXuLyBanDau
                        select obj;
            return query.ToList<LqVuViecEntity>();
		}
		
		
		public List<LqVuViecEntity> SelectBySoHinhThucXuLyBanDau(string SoHinhThucXuLyBanDau)
		{
			var query = from obj in provider.GetTable<LqVuViecEntity>()
                        where obj.SoHinhThucXuLyBanDau == SoHinhThucXuLyBanDau
                        select obj;
            return query.ToList<LqVuViecEntity>();
		}
		
		
		public List<LqVuViecEntity> SelectByNgayXuLy(DateTime NgayXuLy)
		{
			var query = from obj in provider.GetTable<LqVuViecEntity>()
                        where obj.NgayXuLy.Value == NgayXuLy
                        select obj;
            return query.ToList<LqVuViecEntity>();
		}
		
		
		public List<LqVuViecEntity> SelectByNgayKetLuan(DateTime NgayKetLuan)
		{
			var query = from obj in provider.GetTable<LqVuViecEntity>()
                        where obj.NgayKetLuan.Value == NgayKetLuan
                        select obj;
            return query.ToList<LqVuViecEntity>();
		}
		
		
		public List<LqVuViecEntity> SelectBySoDinhChiTamDinhChi(string SoDinhChiTamDinhChi)
		{
			var query = from obj in provider.GetTable<LqVuViecEntity>()
                        where obj.SoDinhChiTamDinhChi == SoDinhChiTamDinhChi
                        select obj;
            return query.ToList<LqVuViecEntity>();
		}
		
		
		public List<LqVuViecEntity> SelectByNgayDinhChi(DateTime NgayDinhChi)
		{
			var query = from obj in provider.GetTable<LqVuViecEntity>()
                        where obj.NgayDinhChi.Value == NgayDinhChi
                        select obj;
            return query.ToList<LqVuViecEntity>();
		}
		
		
		public List<LqVuViecEntity> SelectBySoBanAn(string SoBanAn)
		{
			var query = from obj in provider.GetTable<LqVuViecEntity>()
                        where obj.SoBanAn == SoBanAn
                        select obj;
            return query.ToList<LqVuViecEntity>();
		}
		
		
		public List<LqVuViecEntity> SelectByNgayBanAn(DateTime NgayBanAn)
		{
			var query = from obj in provider.GetTable<LqVuViecEntity>()
                        where obj.NgayBanAn.Value == NgayBanAn
                        select obj;
            return query.ToList<LqVuViecEntity>();
		}
		
		
		public List<LqVuViecEntity> SelectBySoHoSo(string SoHoSo)
		{
			var query = from obj in provider.GetTable<LqVuViecEntity>()
                        where obj.SoHoSo == SoHoSo
                        select obj;
            return query.ToList<LqVuViecEntity>();
		}
		
		
		public List<LqVuViecEntity> SelectByMaDonVi(string MaDonVi)
		{
			var query = from obj in provider.GetTable<LqVuViecEntity>()
                        where obj.MaDonVi == MaDonVi
                        select obj;
            return query.ToList<LqVuViecEntity>();
		}
		
		
		public List<LqVuViecEntity> SelectByNgayDangKy(DateTime NgayDangKy)
		{
			var query = from obj in provider.GetTable<LqVuViecEntity>()
                        where obj.NgayDangKy.Value == NgayDangKy
                        select obj;
            return query.ToList<LqVuViecEntity>();
		}
		
		
		public List<LqVuViecEntity> SelectBySoDangKy(string SoDangKy)
		{
			var query = from obj in provider.GetTable<LqVuViecEntity>()
                        where obj.SoDangKy == SoDangKy
                        select obj;
            return query.ToList<LqVuViecEntity>();
		}
		
		
		public List<LqVuViecEntity> SelectByNgayNopLuu(DateTime NgayNopLuu)
		{
			var query = from obj in provider.GetTable<LqVuViecEntity>()
                        where obj.NgayNopLuu.Value == NgayNopLuu
                        select obj;
            return query.ToList<LqVuViecEntity>();
		}
		
		
		public List<LqVuViecEntity> SelectBySoNopLuu(DateTime SoNopLuu)
		{
			var query = from obj in provider.GetTable<LqVuViecEntity>()
                        where obj.SoNopLuu.Value == SoNopLuu
                        select obj;
            return query.ToList<LqVuViecEntity>();
		}
		
		
		public List<LqVuViecEntity> SelectByTrangThaiCoToChuc(string TrangThaiCoToChuc)
		{
			var query = from obj in provider.GetTable<LqVuViecEntity>()
                        where obj.TrangThaiCoToChuc == TrangThaiCoToChuc
                        select obj;
            return query.ToList<LqVuViecEntity>();
		}
		
		
		public List<LqVuViecEntity> SelectByIdLoaiDiaBan(Guid IdLoaiDiaBan)
		{
			var query = from obj in provider.GetTable<LqVuViecEntity>()
                        where obj.IdLoaiDiaBan.Value == IdLoaiDiaBan
                        select obj;
            return query.ToList<LqVuViecEntity>();
		}
		
		
		public List<LqVuViecEntity> SelectByIdTinhChatLienQuan(Guid IdTinhChatLienQuan)
		{
			var query = from obj in provider.GetTable<LqVuViecEntity>()
                        where obj.IdTinhChatLienQuan.Value == IdTinhChatLienQuan
                        select obj;
            return query.ToList<LqVuViecEntity>();
		}
		
		
		public List<LqVuViecEntity> SelectByNoiDungLienQuan(string NoiDungLienQuan)
		{
			var query = from obj in provider.GetTable<LqVuViecEntity>()
                        where obj.NoiDungLienQuan == NoiDungLienQuan
                        select obj;
            return query.ToList<LqVuViecEntity>();
		}
		
		
		public List<LqVuViecEntity> SelectByTieuDeVuViec(string TieuDeVuViec)
		{
			var query = from obj in provider.GetTable<LqVuViecEntity>()
                        where obj.TieuDeVuViec == TieuDeVuViec
                        select obj;
            return query.ToList<LqVuViecEntity>();
		}
		
		
		public List<LqVuViecEntity> SelectByIdVanDeKhac(Guid IdVanDeKhac)
		{
			var query = from obj in provider.GetTable<LqVuViecEntity>()
                        where obj.IdVanDeKhac.Value == IdVanDeKhac
                        select obj;
            return query.ToList<LqVuViecEntity>();
		}
		
		
		public List<LqVuViecEntity> SelectByIdXuLyKhac(Guid IdXuLyKhac)
		{
			var query = from obj in provider.GetTable<LqVuViecEntity>()
                        where obj.IdXuLyKhac.Value == IdXuLyKhac
                        select obj;
            return query.ToList<LqVuViecEntity>();
		}
		
		
		public List<LqVuViecEntity> SelectByTongSoBat(int TongSoBat)
		{
			var query = from obj in provider.GetTable<LqVuViecEntity>()
                        where obj.TongSoBat.Value == TongSoBat
                        select obj;
            return query.ToList<LqVuViecEntity>();
		}
		
		
		public List<LqVuViecEntity> SelectByTongSoTamGiam(int TongSoTamGiam)
		{
			var query = from obj in provider.GetTable<LqVuViecEntity>()
                        where obj.TongSoTamGiam.Value == TongSoTamGiam
                        select obj;
            return query.ToList<LqVuViecEntity>();
		}
		
		
		public List<LqVuViecEntity> SelectByTongSoTaiNgoai(int TongSoTaiNgoai)
		{
			var query = from obj in provider.GetTable<LqVuViecEntity>()
                        where obj.TongSoTaiNgoai.Value == TongSoTaiNgoai
                        select obj;
            return query.ToList<LqVuViecEntity>();
		}
		
		
		public List<LqVuViecEntity> SelectByTongSoTruyNa(int TongSoTruyNa)
		{
			var query = from obj in provider.GetTable<LqVuViecEntity>()
                        where obj.TongSoTruyNa.Value == TongSoTruyNa
                        select obj;
            return query.ToList<LqVuViecEntity>();
		}
		
		
		public List<LqVuViecEntity> SelectByNoiDungXuLyKhac(string NoiDungXuLyKhac)
		{
			var query = from obj in provider.GetTable<LqVuViecEntity>()
                        where obj.NoiDungXuLyKhac == NoiDungXuLyKhac
                        select obj;
            return query.ToList<LqVuViecEntity>();
		}
		
		
		public List<LqVuViecEntity> SelectByIdNguoiTao(Guid IdNguoiTao)
		{
			var query = from obj in provider.GetTable<LqVuViecEntity>()
                        where obj.IdNguoiTao.Value == IdNguoiTao
                        select obj;
            return query.ToList<LqVuViecEntity>();
		}
		
		
		public List<LqVuViecEntity> SelectByNgayTao(DateTime NgayTao)
		{
			var query = from obj in provider.GetTable<LqVuViecEntity>()
                        where obj.NgayTao == NgayTao
                        select obj;
            return query.ToList<LqVuViecEntity>();
		}
		
		
		public List<LqVuViecEntity> SelectByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			var query = from obj in provider.GetTable<LqVuViecEntity>()
                        where obj.IdNguoiCapNhat.Value == IdNguoiCapNhat
                        select obj;
            return query.ToList<LqVuViecEntity>();
		}
		
		
		public List<LqVuViecEntity> SelectByNgayCapNhat(DateTime NgayCapNhat)
		{
			var query = from obj in provider.GetTable<LqVuViecEntity>()
                        where obj.NgayCapNhat == NgayCapNhat
                        select obj;
            return query.ToList<LqVuViecEntity>();
		}
		
		
		public List<LqVuViecEntity> SelectByTrangThai(bool TrangThai)
		{
			var query = from obj in provider.GetTable<LqVuViecEntity>()
                        where obj.TrangThai == TrangThai
                        select obj;
            return query.ToList<LqVuViecEntity>();
		}
		
		
		

	}
}
